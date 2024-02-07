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
	public class Submit_Ad_Hoc_Goods_Delivery_RequestType : INotifyPropertyChanged
	{
		private Goods_DeliveryObjectType goods_Delivery_Ticket_ReferenceField;

		private Financials_Business_Process_ParametersType business_Process_ParametersField;

		private Ad_Hoc_Goods_Delivery_DataType[] goods_Delivery_Ticket_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Goods_DeliveryObjectType Goods_Delivery_Ticket_Reference
		{
			get
			{
				return this.goods_Delivery_Ticket_ReferenceField;
			}
			set
			{
				this.goods_Delivery_Ticket_ReferenceField = value;
				this.RaisePropertyChanged("Goods_Delivery_Ticket_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Financials_Business_Process_ParametersType Business_Process_Parameters
		{
			get
			{
				return this.business_Process_ParametersField;
			}
			set
			{
				this.business_Process_ParametersField = value;
				this.RaisePropertyChanged("Business_Process_Parameters");
			}
		}

		[XmlElement("Goods_Delivery_Ticket_Data", Order = 2)]
		public Ad_Hoc_Goods_Delivery_DataType[] Goods_Delivery_Ticket_Data
		{
			get
			{
				return this.goods_Delivery_Ticket_DataField;
			}
			set
			{
				this.goods_Delivery_Ticket_DataField = value;
				this.RaisePropertyChanged("Goods_Delivery_Ticket_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
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
