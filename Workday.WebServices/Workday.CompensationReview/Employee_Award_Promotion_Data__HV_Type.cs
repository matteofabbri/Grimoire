using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CompensationReview
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Employee_Award_Promotion_Data__HV_Type : INotifyPropertyChanged
	{
		private bool promoteField;

		private bool promoteFieldSpecified;

		private decimal itemField;

		private ItemChoiceType3 itemElementNameField;

		private Event_Classification_SubcategoryObjectType promotion_Reason_ReferenceField;

		private Compensation_GradeObjectType compensation_Grade_ReferenceField;

		private Compensation_Grade_ProfileObjectType grade_Profile_ReferenceField;

		private Job_ProfileObjectType job_Profile_ReferenceField;

		private Position_ElementObjectType position_ReferenceField;

		private LocationObjectType location_ReferenceField;

		private decimal scheduled_Weekly_HoursField;

		private bool scheduled_Weekly_HoursFieldSpecified;

		private string promotion_NotesField;

		private string business_TitleField;

		private string job_TitleField;

		private Pay_Rate_TypeObjectType pay_Rate_Type_ReferenceField;

		private LocationObjectType workspace_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Promote
		{
			get
			{
				return this.promoteField;
			}
			set
			{
				this.promoteField = value;
				this.RaisePropertyChanged("Promote");
			}
		}

		[XmlIgnore]
		public bool PromoteSpecified
		{
			get
			{
				return this.promoteFieldSpecified;
			}
			set
			{
				this.promoteFieldSpecified = value;
				this.RaisePropertyChanged("PromoteSpecified");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Promotion_Amount", typeof(decimal), Order = 1), XmlElement("Promotion_New_Pay_Amount", typeof(decimal), Order = 1), XmlElement("Promotion_Percent", typeof(decimal), Order = 1)]
		public decimal Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 2), XmlIgnore]
		public ItemChoiceType3 ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
			}
		}

		[XmlElement(Order = 3)]
		public Event_Classification_SubcategoryObjectType Promotion_Reason_Reference
		{
			get
			{
				return this.promotion_Reason_ReferenceField;
			}
			set
			{
				this.promotion_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Promotion_Reason_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Compensation_GradeObjectType Compensation_Grade_Reference
		{
			get
			{
				return this.compensation_Grade_ReferenceField;
			}
			set
			{
				this.compensation_Grade_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Grade_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Compensation_Grade_ProfileObjectType Grade_Profile_Reference
		{
			get
			{
				return this.grade_Profile_ReferenceField;
			}
			set
			{
				this.grade_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Grade_Profile_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Job_ProfileObjectType Job_Profile_Reference
		{
			get
			{
				return this.job_Profile_ReferenceField;
			}
			set
			{
				this.job_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Job_Profile_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Position_ElementObjectType Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public LocationObjectType Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Scheduled_Weekly_Hours
		{
			get
			{
				return this.scheduled_Weekly_HoursField;
			}
			set
			{
				this.scheduled_Weekly_HoursField = value;
				this.RaisePropertyChanged("Scheduled_Weekly_Hours");
			}
		}

		[XmlIgnore]
		public bool Scheduled_Weekly_HoursSpecified
		{
			get
			{
				return this.scheduled_Weekly_HoursFieldSpecified;
			}
			set
			{
				this.scheduled_Weekly_HoursFieldSpecified = value;
				this.RaisePropertyChanged("Scheduled_Weekly_HoursSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public string Promotion_Notes
		{
			get
			{
				return this.promotion_NotesField;
			}
			set
			{
				this.promotion_NotesField = value;
				this.RaisePropertyChanged("Promotion_Notes");
			}
		}

		[XmlElement(Order = 11)]
		public string Business_Title
		{
			get
			{
				return this.business_TitleField;
			}
			set
			{
				this.business_TitleField = value;
				this.RaisePropertyChanged("Business_Title");
			}
		}

		[XmlElement(Order = 12)]
		public string Job_Title
		{
			get
			{
				return this.job_TitleField;
			}
			set
			{
				this.job_TitleField = value;
				this.RaisePropertyChanged("Job_Title");
			}
		}

		[XmlElement(Order = 13)]
		public Pay_Rate_TypeObjectType Pay_Rate_Type_Reference
		{
			get
			{
				return this.pay_Rate_Type_ReferenceField;
			}
			set
			{
				this.pay_Rate_Type_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Rate_Type_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public LocationObjectType Workspace_Reference
		{
			get
			{
				return this.workspace_ReferenceField;
			}
			set
			{
				this.workspace_ReferenceField = value;
				this.RaisePropertyChanged("Workspace_Reference");
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
