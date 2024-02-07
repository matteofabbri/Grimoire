using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Inventory_Par_Location_DataType : INotifyPropertyChanged
	{
		private LocationObjectType par_Location_ReferenceField;

		private CompanyObjectType par_Company_ReferenceField;

		private Par_Count_OptionObjectType par_Count_Options_ReferenceField;

		private LocationObjectType source_Inventory_Site_ReferenceField;

		private CompanyObjectType source_Requisition_Company_ReferenceField;

		private Inventory_Stock_Request_TypeObjectType inventory_Stock_Request_Type_ReferenceField;

		private Requisition_TypeObjectType requisition_Type_ReferenceField;

		private Audited_Accounting_WorktagObjectType[] worktags_ReferenceField;

		private Inventory_Par_Location_Line_DataType[] inventory_Par_Location_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public LocationObjectType Par_Location_Reference
		{
			get
			{
				return this.par_Location_ReferenceField;
			}
			set
			{
				this.par_Location_ReferenceField = value;
				this.RaisePropertyChanged("Par_Location_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public CompanyObjectType Par_Company_Reference
		{
			get
			{
				return this.par_Company_ReferenceField;
			}
			set
			{
				this.par_Company_ReferenceField = value;
				this.RaisePropertyChanged("Par_Company_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Par_Count_OptionObjectType Par_Count_Options_Reference
		{
			get
			{
				return this.par_Count_Options_ReferenceField;
			}
			set
			{
				this.par_Count_Options_ReferenceField = value;
				this.RaisePropertyChanged("Par_Count_Options_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public LocationObjectType Source_Inventory_Site_Reference
		{
			get
			{
				return this.source_Inventory_Site_ReferenceField;
			}
			set
			{
				this.source_Inventory_Site_ReferenceField = value;
				this.RaisePropertyChanged("Source_Inventory_Site_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public CompanyObjectType Source_Requisition_Company_Reference
		{
			get
			{
				return this.source_Requisition_Company_ReferenceField;
			}
			set
			{
				this.source_Requisition_Company_ReferenceField = value;
				this.RaisePropertyChanged("Source_Requisition_Company_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Inventory_Stock_Request_TypeObjectType Inventory_Stock_Request_Type_Reference
		{
			get
			{
				return this.inventory_Stock_Request_Type_ReferenceField;
			}
			set
			{
				this.inventory_Stock_Request_Type_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Stock_Request_Type_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Requisition_TypeObjectType Requisition_Type_Reference
		{
			get
			{
				return this.requisition_Type_ReferenceField;
			}
			set
			{
				this.requisition_Type_ReferenceField = value;
				this.RaisePropertyChanged("Requisition_Type_Reference");
			}
		}

		[XmlElement("Worktags_Reference", Order = 7)]
		public Audited_Accounting_WorktagObjectType[] Worktags_Reference
		{
			get
			{
				return this.worktags_ReferenceField;
			}
			set
			{
				this.worktags_ReferenceField = value;
				this.RaisePropertyChanged("Worktags_Reference");
			}
		}

		[XmlElement("Inventory_Par_Location_Line_Data", Order = 8)]
		public Inventory_Par_Location_Line_DataType[] Inventory_Par_Location_Line_Data
		{
			get
			{
				return this.inventory_Par_Location_Line_DataField;
			}
			set
			{
				this.inventory_Par_Location_Line_DataField = value;
				this.RaisePropertyChanged("Inventory_Par_Location_Line_Data");
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
