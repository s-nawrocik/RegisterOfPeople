using RegisterOfPeopleApp.Helpers;
using RegisterOfPeopleApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RegisterOfPeopleApp.ViewModel
{
    public class PersonViewModel : BaseViewModel, IDataErrorInfo
    {
        public RelayCommand EditCommand { get; private set; }

        public Person person { get; set; }

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChange("FirstName");
            }
        }
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChange("LastName");
            }
        }
        public string StreetAddress
        {
            get { return $"{StreetName} {HouseNumber}" + (String.IsNullOrWhiteSpace(ApartmentNumber) ? String.Empty : ("/" + ApartmentNumber)); }
        }
        private string streetName;
        public string StreetName
        {
            get { return streetName; }
            set
            {
                streetName = value;
                OnPropertyChange("StreetName");
                OnPropertyChange("StreetAddress");
            }
        }
        private string houseNumber;
        public string HouseNumber
        {
            get { return houseNumber; }
            set
            {
                houseNumber = value;
                OnPropertyChange("HouseNumber");
                OnPropertyChange("StreetAddress");
            }
        }
        private string apartmentNumber;
        public string ApartmentNumber
        {
            get { return apartmentNumber; }
            set
            {
                apartmentNumber = value;
                OnPropertyChange("ApartmentNumber");
                OnPropertyChange("StreetAddress");
            }
        }
        private string postalCode;
        public string PostalCode
        {
            get { return postalCode; }
            set
            {
                postalCode = value;
                OnPropertyChange("PostalCode");
            }
        }
        private string town;
        public string Town
        {
            get { return town; }
            set
            {
                town = value;
                OnPropertyChange("Town");
            }
        }
        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                phoneNumber = value;
                OnPropertyChange("PhoneNumber");
            }
        }
        private DateTime? dateOfBirth;
        public DateTime? DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                var today = DateTime.Today;
                if (value.HasValue && value <= today)
                {
                    dateOfBirth = value;
                    age = today.Year - dateOfBirth.Value.Year;
                    if (dateOfBirth.Value.AddYears(age) > today)
                    {
                        age--;
                    }
                    Age = age;
                }
                else
                    dateOfBirth = null;
                OnPropertyChange("DateOfBirth");
            }
        }
        private int age;
        public int Age
        {
            get { return age; }
            private set
            {
                age = value;
                OnPropertyChange("Age");
            }
        }
        private bool isInEdit;
        public bool IsInEdit
        {
            get { return isInEdit; }
            set
            {
                isInEdit = value;
                OnPropertyChange("IsInEdit");
            }
        }
        private bool isNew;
        private bool dontValidateOnInit;
        public bool IsNew
        {
            get { return isNew; }
            set
            {
                isNew = value;
                dontValidateOnInit = value;
                OnPropertyChange("IsNew");
            }
        }
        private bool isChanged;
        public bool IsChanged
        {
            get { return isChanged; }
            set
            {
                isChanged = value;
                OnPropertyChange("IsChanged");
            }
        }
        public string Error => "Error";
        public string this[string propertyName]
        {
            get { return IsValid(propertyName); }
        }
                
        public PersonViewModel(Person person)
        {
            this.person = person;
            AssignProperties();

            EditCommand = new RelayCommand(() => IsInEdit = true);
        }

        public bool AcceptChanges()
        {
            if (CheckIfValid())
            {
                IsChanged = CheckForChanges();
                person.FirstName = FirstName;
                person.LastName = LastName;
                person.StreetName = StreetName;
                person.HouseNumber = HouseNumber;
                person.ApartmentNumber = ApartmentNumber;
                person.PostalCode = PostalCode;
                person.Town = Town;
                person.PhoneNumber = PhoneNumber;
                person.DateOfBirth = DateOfBirth.Value;
                IsInEdit = false;
                IsNew = false;
            }
            return IsChanged;
        }        
        public void RejectChanges()
        {
            AssignProperties();
            IsInEdit = false;
        }
        private void AssignProperties()
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            StreetName = person.StreetName;
            HouseNumber = person.HouseNumber;
            ApartmentNumber = person.ApartmentNumber;
            PostalCode = person.PostalCode;
            Town = person.Town;
            PhoneNumber = person.PhoneNumber;
            DateOfBirth = person.DateOfBirth;
        }
        private bool CheckForChanges()
        {
            return (FirstName != person.FirstName ||
                    LastName != person.LastName ||
                    StreetName != person.StreetName ||
                    HouseNumber != person.HouseNumber ||
                    ApartmentNumber != person.ApartmentNumber ||
                    PostalCode != person.PostalCode ||
                    Town != person.Town ||
                    PhoneNumber != person.PhoneNumber ||
                    DateOfBirth != person.DateOfBirth);
        }
        private bool CheckIfValid()
        {
            if (dontValidateOnInit)
            {
                dontValidateOnInit = false;
                OnPropertyChange(null);
            }
            string errors = IsValid(nameof(FirstName)) +
                IsValid(nameof(LastName)) +
                IsValid(nameof(StreetName)) +
                IsValid(nameof(HouseNumber)) +
                IsValid(nameof(PostalCode)) +
                IsValid(nameof(Town)) +
                IsValid(nameof(PhoneNumber)) +
                IsValid(nameof(DateOfBirth));
            return errors == String.Empty;
        }
        private string IsValid(string propertyName)
        {
            string errorMessage = String.Empty;
            if (!dontValidateOnInit)
            {
                System.Reflection.PropertyInfo property = typeof(PersonViewModel).GetProperty(propertyName);
                switch (propertyName)
                {
                    case nameof(FirstName):
                    case nameof(LastName):
                    case nameof(StreetName):
                    case nameof(HouseNumber):
                    case nameof(PostalCode):
                    case nameof(Town):
                        if (String.IsNullOrWhiteSpace((string)property.GetValue(this)))
                        {
                            errorMessage = $"{SplitCamelCase(propertyName)} is a mandatory field.";
                        }
                        break;
                    case nameof(PhoneNumber):
                        if (String.IsNullOrWhiteSpace(PhoneNumber))
                        {
                            errorMessage = "Phone Number is mandatory field.";
                        }
                        else
                        {
                            if (!Regex.Match(PhoneNumber, "^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\\s\\./0-9]*$").Success)
                                errorMessage = "Wrong format of Phone Number.";
                        }
                        break;
                    case nameof(DateOfBirth):
                        if (!DateOfBirth.HasValue)
                            errorMessage = "Date Of Birth is mandatory field.";
                        break;
                }
            }
            return errorMessage;
        }
        private string SplitCamelCase(string value)
        {
            return Regex.Replace(value, @"(\B[A-Z]+?(?=[A-Z][^A-Z])|\B[A-Z]+?(?=[^A-Z]))", " $1");
        }
    }
}
