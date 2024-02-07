using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Education_Test_Result__HV__DataType : INotifyPropertyChanged
	{
		private bool pendingField;

		private bool pendingFieldSpecified;

		private Has_Academic_Unit_No_Level_DataType has_Academic_Unit_DataField;

		private DateTime date_TakenField;

		private string registration_NumberField;

		private bool officialField;

		private bool officialFieldSpecified;

		private DateTime received_DateField;

		private bool received_DateFieldSpecified;

		private Education_Test__All_ObjectType education_Test_ReferenceField;

		private Education_Test_Section_Result_Subedit_DataType[] education_Test_Section_Result_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Pending
		{
			get
			{
				return this.pendingField;
			}
			set
			{
				this.pendingField = value;
				this.RaisePropertyChanged("Pending");
			}
		}

		[XmlIgnore]
		public bool PendingSpecified
		{
			get
			{
				return this.pendingFieldSpecified;
			}
			set
			{
				this.pendingFieldSpecified = value;
				this.RaisePropertyChanged("PendingSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Has_Academic_Unit_No_Level_DataType Has_Academic_Unit_Data
		{
			get
			{
				return this.has_Academic_Unit_DataField;
			}
			set
			{
				this.has_Academic_Unit_DataField = value;
				this.RaisePropertyChanged("Has_Academic_Unit_Data");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Date_Taken
		{
			get
			{
				return this.date_TakenField;
			}
			set
			{
				this.date_TakenField = value;
				this.RaisePropertyChanged("Date_Taken");
			}
		}

		[XmlElement(Order = 3)]
		public string Registration_Number
		{
			get
			{
				return this.registration_NumberField;
			}
			set
			{
				this.registration_NumberField = value;
				this.RaisePropertyChanged("Registration_Number");
			}
		}

		[XmlElement(Order = 4)]
		public bool Official
		{
			get
			{
				return this.officialField;
			}
			set
			{
				this.officialField = value;
				this.RaisePropertyChanged("Official");
			}
		}

		[XmlIgnore]
		public bool OfficialSpecified
		{
			get
			{
				return this.officialFieldSpecified;
			}
			set
			{
				this.officialFieldSpecified = value;
				this.RaisePropertyChanged("OfficialSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Received_Date
		{
			get
			{
				return this.received_DateField;
			}
			set
			{
				this.received_DateField = value;
				this.RaisePropertyChanged("Received_Date");
			}
		}

		[XmlIgnore]
		public bool Received_DateSpecified
		{
			get
			{
				return this.received_DateFieldSpecified;
			}
			set
			{
				this.received_DateFieldSpecified = value;
				this.RaisePropertyChanged("Received_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public Education_Test__All_ObjectType Education_Test_Reference
		{
			get
			{
				return this.education_Test_ReferenceField;
			}
			set
			{
				this.education_Test_ReferenceField = value;
				this.RaisePropertyChanged("Education_Test_Reference");
			}
		}

		[XmlElement("Education_Test_Section_Result_Data", Order = 7)]
		public Education_Test_Section_Result_Subedit_DataType[] Education_Test_Section_Result_Data
		{
			get
			{
				return this.education_Test_Section_Result_DataField;
			}
			set
			{
				this.education_Test_Section_Result_DataField = value;
				this.RaisePropertyChanged("Education_Test_Section_Result_Data");
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
