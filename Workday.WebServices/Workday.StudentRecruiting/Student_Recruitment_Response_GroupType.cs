using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Recruitment_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_Person_DataField;

		private bool include_Person_DataFieldSpecified;

		private bool include_Personal_Portfolio_DataField;

		private bool include_Personal_Portfolio_DataFieldSpecified;

		private bool include_School_DataField;

		private bool include_School_DataFieldSpecified;

		private bool include_Friends_and_Family_DataField;

		private bool include_Friends_and_Family_DataFieldSpecified;

		private bool include_Additional_Data_In_ResponseField;

		private bool include_Additional_Data_In_ResponseFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Reference
		{
			get
			{
				return this.include_ReferenceField;
			}
			set
			{
				this.include_ReferenceField = value;
				this.RaisePropertyChanged("Include_Reference");
			}
		}

		[XmlIgnore]
		public bool Include_ReferenceSpecified
		{
			get
			{
				return this.include_ReferenceFieldSpecified;
			}
			set
			{
				this.include_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Include_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_Person_Data
		{
			get
			{
				return this.include_Person_DataField;
			}
			set
			{
				this.include_Person_DataField = value;
				this.RaisePropertyChanged("Include_Person_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Person_DataSpecified
		{
			get
			{
				return this.include_Person_DataFieldSpecified;
			}
			set
			{
				this.include_Person_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Person_DataSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Personal_Portfolio_Data
		{
			get
			{
				return this.include_Personal_Portfolio_DataField;
			}
			set
			{
				this.include_Personal_Portfolio_DataField = value;
				this.RaisePropertyChanged("Include_Personal_Portfolio_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Personal_Portfolio_DataSpecified
		{
			get
			{
				return this.include_Personal_Portfolio_DataFieldSpecified;
			}
			set
			{
				this.include_Personal_Portfolio_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Personal_Portfolio_DataSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Include_School_Data
		{
			get
			{
				return this.include_School_DataField;
			}
			set
			{
				this.include_School_DataField = value;
				this.RaisePropertyChanged("Include_School_Data");
			}
		}

		[XmlIgnore]
		public bool Include_School_DataSpecified
		{
			get
			{
				return this.include_School_DataFieldSpecified;
			}
			set
			{
				this.include_School_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_School_DataSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Include_Friends_and_Family_Data
		{
			get
			{
				return this.include_Friends_and_Family_DataField;
			}
			set
			{
				this.include_Friends_and_Family_DataField = value;
				this.RaisePropertyChanged("Include_Friends_and_Family_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Friends_and_Family_DataSpecified
		{
			get
			{
				return this.include_Friends_and_Family_DataFieldSpecified;
			}
			set
			{
				this.include_Friends_and_Family_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Friends_and_Family_DataSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Include_Additional_Data_In_Response
		{
			get
			{
				return this.include_Additional_Data_In_ResponseField;
			}
			set
			{
				this.include_Additional_Data_In_ResponseField = value;
				this.RaisePropertyChanged("Include_Additional_Data_In_Response");
			}
		}

		[XmlIgnore]
		public bool Include_Additional_Data_In_ResponseSpecified
		{
			get
			{
				return this.include_Additional_Data_In_ResponseFieldSpecified;
			}
			set
			{
				this.include_Additional_Data_In_ResponseFieldSpecified = value;
				this.RaisePropertyChanged("Include_Additional_Data_In_ResponseSpecified");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
