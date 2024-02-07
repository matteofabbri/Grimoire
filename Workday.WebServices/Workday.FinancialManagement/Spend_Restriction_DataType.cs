using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Spend_Restriction_DataType : INotifyPropertyChanged
	{
		private string spend_Restriction_NameField;

		private string spend_Restriction_Reference_IDField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private bool itemField;

		private ItemChoiceType4 itemElementNameField;

		private Spend_Restriction_TypeObjectType spend_Restriction_Type_ReferenceField;

		private Object_Class_SetObjectType object_Class_Set_ReferenceField;

		private Spend_Category_HierarchyObjectType[] spend_Category_Hierarchies_ReferenceField;

		private Spend_CategoryObjectType[] spend_Categories_ReferenceField;

		private Pay_Component_Group__All_ObjectType[] pay_Component_Groups_ReferenceField;

		private Object_ClassObjectType[] object_Classes_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Spend_Restriction_Name
		{
			get
			{
				return this.spend_Restriction_NameField;
			}
			set
			{
				this.spend_Restriction_NameField = value;
				this.RaisePropertyChanged("Spend_Restriction_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Spend_Restriction_Reference_ID
		{
			get
			{
				return this.spend_Restriction_Reference_IDField;
			}
			set
			{
				this.spend_Restriction_Reference_IDField = value;
				this.RaisePropertyChanged("Spend_Restriction_Reference_ID");
			}
		}

		[XmlElement(Order = 2)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Allowable_Costs", typeof(bool), Order = 3), XmlElement("Unallowable_Costs", typeof(bool), Order = 3)]
		public bool Item
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

		[XmlElement(Order = 4), XmlIgnore]
		public ItemChoiceType4 ItemElementName
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

		[XmlElement(Order = 5)]
		public Spend_Restriction_TypeObjectType Spend_Restriction_Type_Reference
		{
			get
			{
				return this.spend_Restriction_Type_ReferenceField;
			}
			set
			{
				this.spend_Restriction_Type_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Restriction_Type_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Object_Class_SetObjectType Object_Class_Set_Reference
		{
			get
			{
				return this.object_Class_Set_ReferenceField;
			}
			set
			{
				this.object_Class_Set_ReferenceField = value;
				this.RaisePropertyChanged("Object_Class_Set_Reference");
			}
		}

		[XmlElement("Spend_Category_Hierarchies_Reference", Order = 7)]
		public Spend_Category_HierarchyObjectType[] Spend_Category_Hierarchies_Reference
		{
			get
			{
				return this.spend_Category_Hierarchies_ReferenceField;
			}
			set
			{
				this.spend_Category_Hierarchies_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Category_Hierarchies_Reference");
			}
		}

		[XmlElement("Spend_Categories_Reference", Order = 8)]
		public Spend_CategoryObjectType[] Spend_Categories_Reference
		{
			get
			{
				return this.spend_Categories_ReferenceField;
			}
			set
			{
				this.spend_Categories_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Categories_Reference");
			}
		}

		[XmlElement("Pay_Component_Groups_Reference", Order = 9)]
		public Pay_Component_Group__All_ObjectType[] Pay_Component_Groups_Reference
		{
			get
			{
				return this.pay_Component_Groups_ReferenceField;
			}
			set
			{
				this.pay_Component_Groups_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Component_Groups_Reference");
			}
		}

		[XmlElement("Object_Classes_Reference", Order = 10)]
		public Object_ClassObjectType[] Object_Classes_Reference
		{
			get
			{
				return this.object_Classes_ReferenceField;
			}
			set
			{
				this.object_Classes_ReferenceField = value;
				this.RaisePropertyChanged("Object_Classes_Reference");
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
