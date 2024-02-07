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
	public class Beneficiary_Person_DataType : INotifyPropertyChanged
	{
		private Related_Person_for_WorkerObjectType existing_Related_Person_ReferenceField;

		private Related_Person_RelationshipObjectType related_Person_Relationship_ReferenceField;

		private bool irrevocableField;

		private bool irrevocableFieldSpecified;

		private bool use_Employee_AddressField;

		private bool use_Employee_AddressFieldSpecified;

		private bool use_Employee_PhoneField;

		private bool use_Employee_PhoneFieldSpecified;

		private Beneficiary_Personal_Information_DataType[] beneficiary_Person_Personal_Information_DataField;

		private Qualified_Domestic_Relations_Order_Replacement_DataType[] court_OrderField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement("Beneficiary_Person_Personal_Information_Data", Order = 5)]
		public Beneficiary_Personal_Information_DataType[] Beneficiary_Person_Personal_Information_Data
		{
			get
			{
				return this.beneficiary_Person_Personal_Information_DataField;
			}
			set
			{
				this.beneficiary_Person_Personal_Information_DataField = value;
				this.RaisePropertyChanged("Beneficiary_Person_Personal_Information_Data");
			}
		}

		[XmlElement("Court_Order", Order = 6)]
		public Qualified_Domestic_Relations_Order_Replacement_DataType[] Court_Order
		{
			get
			{
				return this.court_OrderField;
			}
			set
			{
				this.court_OrderField = value;
				this.RaisePropertyChanged("Court_Order");
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
