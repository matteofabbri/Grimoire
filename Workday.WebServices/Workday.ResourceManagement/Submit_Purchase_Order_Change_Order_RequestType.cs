using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Submit_Purchase_Order_Change_Order_RequestType : INotifyPropertyChanged
	{
		private Purchase_Order_Change_OrderObjectType purchase_Order_Change_Order_ReferenceField;

		private Financials_Business_Process_ParametersType business_Process_ParametersField;

		private Purchase_Order_Change_Order_WWS_DataType[] purchase_Order_Change_Order_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Purchase_Order_Change_OrderObjectType Purchase_Order_Change_Order_Reference
		{
			get
			{
				return this.purchase_Order_Change_Order_ReferenceField;
			}
			set
			{
				this.purchase_Order_Change_Order_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Order_Change_Order_Reference");
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

		[XmlElement("Purchase_Order_Change_Order_Data", Order = 2)]
		public Purchase_Order_Change_Order_WWS_DataType[] Purchase_Order_Change_Order_Data
		{
			get
			{
				return this.purchase_Order_Change_Order_DataField;
			}
			set
			{
				this.purchase_Order_Change_Order_DataField = value;
				this.RaisePropertyChanged("Purchase_Order_Change_Order_Data");
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
