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
	public class Submit_Inventory_Shipment_RequestType : INotifyPropertyChanged
	{
		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private Inventory_Ship_ListObjectType inventory_Shipment_ReferenceField;

		private Financials_Business_Process_ParametersType financials_Business_Process_Parameters_ElementField;

		private Inventory_Shipment_Data_InboundType inventory_Shipment_Data_ElementField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Inventory_Ship_ListObjectType Inventory_Shipment_Reference
		{
			get
			{
				return this.inventory_Shipment_ReferenceField;
			}
			set
			{
				this.inventory_Shipment_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Shipment_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Financials_Business_Process_ParametersType Financials_Business_Process_Parameters_Element
		{
			get
			{
				return this.financials_Business_Process_Parameters_ElementField;
			}
			set
			{
				this.financials_Business_Process_Parameters_ElementField = value;
				this.RaisePropertyChanged("Financials_Business_Process_Parameters_Element");
			}
		}

		[XmlElement(Order = 3)]
		public Inventory_Shipment_Data_InboundType Inventory_Shipment_Data_Element
		{
			get
			{
				return this.inventory_Shipment_Data_ElementField;
			}
			set
			{
				this.inventory_Shipment_Data_ElementField = value;
				this.RaisePropertyChanged("Inventory_Shipment_Data_Element");
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
