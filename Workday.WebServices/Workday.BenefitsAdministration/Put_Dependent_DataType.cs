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
	public class Put_Dependent_DataType : INotifyPropertyChanged
	{
		private string dependent_IDField;

		private EmployeeObjectType employee_ReferenceField;

		private Related_Person_for_WorkerObjectType existing_Related_Person_ReferenceField;

		private Related_Person_RelationshipObjectType related_Person_Relationship_ReferenceField;

		private bool use_Employee_AddressField;

		private bool use_Employee_AddressFieldSpecified;

		private bool use_Employee_PhoneField;

		private bool use_Employee_PhoneFieldSpecified;

		private bool irrevocableField;

		private bool irrevocableFieldSpecified;

		private Dependent_Personal_Information_DataType dependent_Personal_Information_DataField;

		private Qualified_Domestic_Relations_Order_Replacement_DataType[] court_Order_Replacement_DataField;

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

		[XmlElement(Order = 1)]
		public EmployeeObjectType Employee_Reference
		{
			get
			{
				return this.employee_ReferenceField;
			}
			set
			{
				this.employee_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Related_Person_for_WorkerObjectType Existing_Related_Person_Reference
		{
			get
			{
				return this.existing_Related_Person_ReferenceField;
			}
			set
			{
				this.existing_Related_Person_ReferenceField = value;
				this.RaisePropertyChanged("Existing_Related_Person_Reference");
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
		public bool Irrevocable
		{
			get
			{
				return this.irrevocableField;
			}
			set
			{
				this.irrevocableField = value;
				this.RaisePropertyChanged("Irrevocable");
			}
		}

		[XmlIgnore]
		public bool IrrevocableSpecified
		{
			get
			{
				return this.irrevocableFieldSpecified;
			}
			set
			{
				this.irrevocableFieldSpecified = value;
				this.RaisePropertyChanged("IrrevocableSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public Dependent_Personal_Information_DataType Dependent_Personal_Information_Data
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

		[XmlElement("Court_Order_Replacement_Data", Order = 8)]
		public Qualified_Domestic_Relations_Order_Replacement_DataType[] Court_Order_Replacement_Data
		{
			get
			{
				return this.court_Order_Replacement_DataField;
			}
			set
			{
				this.court_Order_Replacement_DataField = value;
				this.RaisePropertyChanged("Court_Order_Replacement_Data");
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
