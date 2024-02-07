using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Get_Inventory_Balance_WWS_Main_ResponseType : INotifyPropertyChanged
	{
		private CompanyObjectType company_for_Inventory_ReferenceField;

		private LocationObjectType inventory_Site_ReferenceField;

		private Purchase_ItemObjectType[] inventory_Items_ReferenceField;

		private Asset_Location_or_Location_HierarchyObjectType[] location_or_Location_Hierarchy_ReferenceField;

		private bool show_Inventory_Zero_BalanceField;

		private bool show_Inventory_Zero_BalanceFieldSpecified;

		private Get_Inventory_Balance_Detail_ResponseType[] get_Inventory_Balance_Detail_Response_ElementField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public CompanyObjectType Company_for_Inventory_Reference
		{
			get
			{
				return this.company_for_Inventory_ReferenceField;
			}
			set
			{
				this.company_for_Inventory_ReferenceField = value;
				this.RaisePropertyChanged("Company_for_Inventory_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public LocationObjectType Inventory_Site_Reference
		{
			get
			{
				return this.inventory_Site_ReferenceField;
			}
			set
			{
				this.inventory_Site_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Site_Reference");
			}
		}

		[XmlElement("Inventory_Items_Reference", Order = 2)]
		public Purchase_ItemObjectType[] Inventory_Items_Reference
		{
			get
			{
				return this.inventory_Items_ReferenceField;
			}
			set
			{
				this.inventory_Items_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Items_Reference");
			}
		}

		[XmlElement("Location_or_Location_Hierarchy_Reference", Order = 3)]
		public Asset_Location_or_Location_HierarchyObjectType[] Location_or_Location_Hierarchy_Reference
		{
			get
			{
				return this.location_or_Location_Hierarchy_ReferenceField;
			}
			set
			{
				this.location_or_Location_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Location_or_Location_Hierarchy_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public bool Show_Inventory_Zero_Balance
		{
			get
			{
				return this.show_Inventory_Zero_BalanceField;
			}
			set
			{
				this.show_Inventory_Zero_BalanceField = value;
				this.RaisePropertyChanged("Show_Inventory_Zero_Balance");
			}
		}

		[XmlIgnore]
		public bool Show_Inventory_Zero_BalanceSpecified
		{
			get
			{
				return this.show_Inventory_Zero_BalanceFieldSpecified;
			}
			set
			{
				this.show_Inventory_Zero_BalanceFieldSpecified = value;
				this.RaisePropertyChanged("Show_Inventory_Zero_BalanceSpecified");
			}
		}

		[XmlElement("Get_Inventory_Balance_Detail_Response_Element", Order = 5)]
		public Get_Inventory_Balance_Detail_ResponseType[] Get_Inventory_Balance_Detail_Response_Element
		{
			get
			{
				return this.get_Inventory_Balance_Detail_Response_ElementField;
			}
			set
			{
				this.get_Inventory_Balance_Detail_Response_ElementField = value;
				this.RaisePropertyChanged("Get_Inventory_Balance_Detail_Response_Element");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
