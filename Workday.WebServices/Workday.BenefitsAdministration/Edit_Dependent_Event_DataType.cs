using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Edit_Dependent_Event_DataType : INotifyPropertyChanged
	{
		private string dependent_IDField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private Benefits_Event_SubcategoryObjectType reason_ReferenceField;

		private Related_Person_RelationshipObjectType related_Person_Relationship_ReferenceField;

		private bool use_Employee_AddressField;

		private bool use_Employee_AddressFieldSpecified;

		private bool use_Employee_PhoneField;

		private bool use_Employee_PhoneFieldSpecified;

		private Related_Person_Personal_Information_DataType dependent_Personal_Information_DataField;

		private Qualified_Domestic_Relations_Order_Replacement_DataType[] qualified_Domestic_Relations_Order_Replacement_DataField;

		private bool could_Be_Covered_For_Health_Care_Coverage_ElsewhereField;

		private bool could_Be_Covered_For_Health_Care_Coverage_ElsewhereFieldSpecified;

		private DateTime could_Be_Covered_For_Health_Care_Coverage_Elsewhere_Effective_DateField;

		private bool could_Be_Covered_For_Health_Care_Coverage_Elsewhere_Effective_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Dependent_ID
		{
			get
			{
				return this.dependent_IDField;
			}
			set
			{
				this.dependent_IDField = value;
				this.RaisePropertyChanged("Dependent_ID");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Benefits_Event_SubcategoryObjectType Reason_Reference
		{
			get
			{
				return this.reason_ReferenceField;
			}
			set
			{
				this.reason_ReferenceField = value;
				this.RaisePropertyChanged("Reason_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Related_Person_RelationshipObjectType Related_Person_Relationship_Reference
		{
			get
			{
				return this.related_Person_Relationship_ReferenceField;
			}
			set
			{
				this.related_Person_Relationship_ReferenceField = value;
				this.RaisePropertyChanged("Related_Person_Relationship_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public bool Use_Employee_Address
		{
			get
			{
				return this.use_Employee_AddressField;
			}
			set
			{
				this.use_Employee_AddressField = value;
				this.RaisePropertyChanged("Use_Employee_Address");
			}
		}

		[XmlIgnore]
		public bool Use_Employee_AddressSpecified
		{
			get
			{
				return this.use_Employee_AddressFieldSpecified;
			}
			set
			{
				this.use_Employee_AddressFieldSpecified = value;
				this.RaisePropertyChanged("Use_Employee_AddressSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Use_Employee_Phone
		{
			get
			{
				return this.use_Employee_PhoneField;
			}
			set
			{
				this.use_Employee_PhoneField = value;
				this.RaisePropertyChanged("Use_Employee_Phone");
			}
		}

		[XmlIgnore]
		public bool Use_Employee_PhoneSpecified
		{
			get
			{
				return this.use_Employee_PhoneFieldSpecified;
			}
			set
			{
				this.use_Employee_PhoneFieldSpecified = value;
				this.RaisePropertyChanged("Use_Employee_PhoneSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public Related_Person_Personal_Information_DataType Dependent_Personal_Information_Data
		{
			get
			{
				return this.dependent_Personal_Information_DataField;
			}
			set
			{
				this.dependent_Personal_Information_DataField = value;
				this.RaisePropertyChanged("Dependent_Personal_Information_Data");
			}
		}

		[XmlElement("Qualified_Domestic_Relations_Order_Replacement_Data", Order = 7)]
		public Qualified_Domestic_Relations_Order_Replacement_DataType[] Qualified_Domestic_Relations_Order_Replacement_Data
		{
			get
			{
				return this.qualified_Domestic_Relations_Order_Replacement_DataField;
			}
			set
			{
				this.qualified_Domestic_Relations_Order_Replacement_DataField = value;
				this.RaisePropertyChanged("Qualified_Domestic_Relations_Order_Replacement_Data");
			}
		}

		[XmlElement(Order = 8)]
		public bool Could_Be_Covered_For_Health_Care_Coverage_Elsewhere
		{
			get
			{
				return this.could_Be_Covered_For_Health_Care_Coverage_ElsewhereField;
			}
			set
			{
				this.could_Be_Covered_For_Health_Care_Coverage_ElsewhereField = value;
				this.RaisePropertyChanged("Could_Be_Covered_For_Health_Care_Coverage_Elsewhere");
			}
		}

		[XmlIgnore]
		public bool Could_Be_Covered_For_Health_Care_Coverage_ElsewhereSpecified
		{
			get
			{
				return this.could_Be_Covered_For_Health_Care_Coverage_ElsewhereFieldSpecified;
			}
			set
			{
				this.could_Be_Covered_For_Health_Care_Coverage_ElsewhereFieldSpecified = value;
				this.RaisePropertyChanged("Could_Be_Covered_For_Health_Care_Coverage_ElsewhereSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Could_Be_Covered_For_Health_Care_Coverage_Elsewhere_Effective_Date
		{
			get
			{
				return this.could_Be_Covered_For_Health_Care_Coverage_Elsewhere_Effective_DateField;
			}
			set
			{
				this.could_Be_Covered_For_Health_Care_Coverage_Elsewhere_Effective_DateField = value;
				this.RaisePropertyChanged("Could_Be_Covered_For_Health_Care_Coverage_Elsewhere_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Could_Be_Covered_For_Health_Care_Coverage_Elsewhere_Effective_DateSpecified
		{
			get
			{
				return this.could_Be_Covered_For_Health_Care_Coverage_Elsewhere_Effective_DateFieldSpecified;
			}
			set
			{
				this.could_Be_Covered_For_Health_Care_Coverage_Elsewhere_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Could_Be_Covered_For_Health_Care_Coverage_Elsewhere_Effective_DateSpecified");
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
