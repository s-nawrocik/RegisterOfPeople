using RegisterOfPeopleApp.Helpers;
using RegisterOfPeopleApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterOfPeopleApp.ViewModel
{
    public class RegisterViewModel : BaseViewModel
    {
        public RelayCommand AddNewCommand { get; private set; }
        public RelayCommand DeletePersonCommand { get; private set; }
        public RelayCommand AcceptPersonChangesCommand { get; private set; }
        public RelayCommand RejectPersonChangesCommand { get; private set; }
        public RelayCommand SaveCommand { get; private set; }
        public RelayCommand CancelCommand { get; private set; }

        private DataAccess dataAccess;
        private Register register;
        private ObservableCollection<PersonViewModel> people;
        public ObservableCollection<PersonViewModel> People
        {
            get { return people; }
            set
            {
                people = value;
                OnPropertyChange("People");
            }
        }
        private bool hasChanges;
        public bool HasChanges
        {
            get { return hasChanges; }
            set
            {
                hasChanges = value;
                OnPropertyChange("HasChanges");
            }
        }

        public RegisterViewModel()
        {
            LoadRegister();

            AddNewCommand = new RelayCommand(AddNewPerson);
            DeletePersonCommand = new RelayCommand(DeletePerson);
            AcceptPersonChangesCommand = new RelayCommand(AcceptPersonChanges);
            RejectPersonChangesCommand = new RelayCommand(RejectPersonChanges);
            SaveCommand = new RelayCommand(SaveRegister);
            CancelCommand = new RelayCommand(LoadRegister);
        }

        private void AddNewPerson()
        {
            People.Add(new PersonViewModel(new Person()) { IsInEdit = true, IsNew = true });
        }
        private void DeletePerson(object personObject)
        {
            var person = (PersonViewModel)personObject;
            if (!person.IsNew)
            {
                HasChanges = true;
            }
            People.Remove(person);
        }
        private void AcceptPersonChanges(object personObject)
        {
            var person = (PersonViewModel)personObject;
            var isChanged = person.AcceptChanges();

            if (!HasChanges)
                HasChanges = isChanged;
        }
        private void RejectPersonChanges(object personObject)
        {
            var person = (PersonViewModel)personObject;
            if (person.IsNew)
            {
                DeletePerson(personObject);
            }
            else
            {
                person.RejectChanges();
            }
        }
        private void SaveRegister()
        {
            var people = People.Where(p => !p.IsNew).Select(p => p.person).ToArray();
            var newRegister = new Register(people);
            dataAccess.SaveRegister(newRegister);
            register = newRegister;
            HasChanges = false;
        }
        private void LoadRegister()
        {
            dataAccess = new DataAccess();
            register = dataAccess.GetRegister();
            People = new ObservableCollection<PersonViewModel>();
            register.People.ToList().ForEach(s => People.Add(new PersonViewModel(s)));
            HasChanges = false;
        }
    }
}
