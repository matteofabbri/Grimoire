using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Supplier_Request_CriteriaType : INotifyPropertyChanged
	{
		private DateTime updated_From_DateField;

		private bool updated_From_DateFieldSpecified;

		private DateTime updated_To_DateField;

		private bool updated_To_DateFieldSpecified;

		private Business_Entity_Status_ValueObjectType[] supplier_Status_ReferenceField;

		private Supplier_CategoryObjectType[] supplier_Category_ReferenceField;

		private Supplier_GroupObjectType[] supplier_Group_ReferenceField;

		private string customer_Account_NumberField;

		private string dUNS_NumberField;

		private SupplierObjectType[] parent_Supplier_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DateTime Updated_From_Date
		{
			get
			{
				return this.updated_From_DateField;
			}
			set
			{
				this.updated_From_DateField = value;
				this.RaisePropertyChanged("Updated_From_Date");
			}
		}

		[XmlIgnore]
		public bool Updated_From_DateSpecified
		{
			get
			{
				return this.updated_From_DateFieldSpecified;
			}
			set
			{
				this.updated_From_DateFieldSpecified = value;
				this.RaisePropertyChanged("Updated_From_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public DateTime Updated_To_Date
		{
			get
			{
				return this.updated_To_DateField;
			}
			set
			{
				this.updated_To_DateField = value;
				this.RaisePropertyChanged("Updated_To_Date");
			}
		}

		[XmlIgnore]
		public bool Updated_To_DateSpecified
		{
			get
			{
				return this.updated_To_DateFieldSpecified;
			}
			set
			{
				this.updated_To_DateFieldSpecified = value;
				this.RaisePropertyChanged("Updated_To_DateSpecified");
			}
		}

		[XmlElement("Supplier_Status_Reference", Order = 2)]
		public Business_Entity_Status_ValueObjectType[] Supplier_Status_Reference
		{
			get
			{
				return this.supplier_Status_ReferenceField;
			}
			set
			{
				this.supplier_Status_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Status_Reference");
			}
		}

		[XmlElement("Supplier_Category_Reference", Order = 3)]
		public Supplier_CategoryObjectType[] Supplier_Category_Reference
		{
			get
			{
				return this.supplier_Category_ReferenceField;
			}
			set
			{
				this.supplier_Category_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Category_Reference");
			}
		}

		[XmlElement("Supplier_Group_Reference", Order = 4)]
		public Supplier_GroupObjectType[] Supplier_Group_Reference
		{
			get
			{
				return this.supplier_Group_ReferenceField;
			}
			set
			{
				this.supplier_Group_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Group_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Customer_Account_Number
		{
			get
			{
				return this.customer_Account_NumberField;
			}
			set
			{
				this.customer_Account_NumberField = value;
				this.RaisePropertyChanged("Customer_Account_Number");
			}
		}

		[XmlElement(Order = 6)]
		public string DUNS_Number
		{
			get
			{
				return this.dUNS_NumberField;
			}
			set
			{
				this.dUNS_NumberField = value;
				this.RaisePropertyChanged("DUNS_Number");
			}
		}

		[XmlElement("Parent_Supplier_Reference", Order = 7)]
		public SupplierObjectType[] Parent_Supplier_Reference
		{
			get
			{
				return this.parent_Supplier_ReferenceField;
			}
			set
			{
				this.parent_Supplier_ReferenceField = value;
				this.RaisePropertyChanged("Parent_Supplier_Reference");
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
