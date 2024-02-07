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
	public class Advanced_Ship_Notice_Request_CriteriaType : INotifyPropertyChanged
	{
		private CompanyObjectType[] company_ReferenceField;

		private Resource_ProviderObjectType[] supplier_ReferenceField;

		private Purchase_OrderObjectType[] purchase_Order_ReferenceField;

		private DateTime shipment_DateTime_On_or_AfterField;

		private bool shipment_DateTime_On_or_AfterFieldSpecified;

		private DateTime shipment_DateTime_On_or_BeforeField;

		private bool shipment_DateTime_On_or_BeforeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Company_Reference", Order = 0)]
		public CompanyObjectType[] Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement("Supplier_Reference", Order = 1)]
		public Resource_ProviderObjectType[] Supplier_Reference
		{
			get
			{
				return this.supplier_ReferenceField;
			}
			set
			{
				this.supplier_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Reference");
			}
		}

		[XmlElement("Purchase_Order_Reference", Order = 2)]
		public Purchase_OrderObjectType[] Purchase_Order_Reference
		{
			get
			{
				return this.purchase_Order_ReferenceField;
			}
			set
			{
				this.purchase_Order_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Order_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public DateTime Shipment_DateTime_On_or_After
		{
			get
			{
				return this.shipment_DateTime_On_or_AfterField;
			}
			set
			{
				this.shipment_DateTime_On_or_AfterField = value;
				this.RaisePropertyChanged("Shipment_DateTime_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Shipment_DateTime_On_or_AfterSpecified
		{
			get
			{
				return this.shipment_DateTime_On_or_AfterFieldSpecified;
			}
			set
			{
				this.shipment_DateTime_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Shipment_DateTime_On_or_AfterSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public DateTime Shipment_DateTime_On_or_Before
		{
			get
			{
				return this.shipment_DateTime_On_or_BeforeField;
			}
			set
			{
				this.shipment_DateTime_On_or_BeforeField = value;
				this.RaisePropertyChanged("Shipment_DateTime_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Shipment_DateTime_On_or_BeforeSpecified
		{
			get
			{
				return this.shipment_DateTime_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.shipment_DateTime_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Shipment_DateTime_On_or_BeforeSpecified");
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
