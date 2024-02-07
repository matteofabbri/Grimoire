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
	public class Purchase_Order_Acknowledgement_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] organization_ReferenceField;

		private SupplierObjectType[] supplier_ReferenceField;

		private PO_Acknowledgement_StatusObjectType[] acknowledgement_Type_ReferenceField;

		private Purchase_OrderObjectType purchase_Order_ReferenceField;

		private DateTime purchase_Order_Acknowledgement_Date_On_or_AfterField;

		private bool purchase_Order_Acknowledgement_Date_On_or_AfterFieldSpecified;

		private DateTime purchase_Order_Acknowledgement_Date_On_or_BeforeField;

		private bool purchase_Order_Acknowledgement_Date_On_or_BeforeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Organization_Reference", Order = 0)]
		public OrganizationObjectType[] Organization_Reference
		{
			get
			{
				return this.organization_ReferenceField;
			}
			set
			{
				this.organization_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Reference");
			}
		}

		[XmlElement("Supplier_Reference", Order = 1)]
		public SupplierObjectType[] Supplier_Reference
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

		[XmlElement("Acknowledgement_Type_Reference", Order = 2)]
		public PO_Acknowledgement_StatusObjectType[] Acknowledgement_Type_Reference
		{
			get
			{
				return this.acknowledgement_Type_ReferenceField;
			}
			set
			{
				this.acknowledgement_Type_ReferenceField = value;
				this.RaisePropertyChanged("Acknowledgement_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Purchase_OrderObjectType Purchase_Order_Reference
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

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Purchase_Order_Acknowledgement_Date_On_or_After
		{
			get
			{
				return this.purchase_Order_Acknowledgement_Date_On_or_AfterField;
			}
			set
			{
				this.purchase_Order_Acknowledgement_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Purchase_Order_Acknowledgement_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Purchase_Order_Acknowledgement_Date_On_or_AfterSpecified
		{
			get
			{
				return this.purchase_Order_Acknowledgement_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.purchase_Order_Acknowledgement_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Purchase_Order_Acknowledgement_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Purchase_Order_Acknowledgement_Date_On_or_Before
		{
			get
			{
				return this.purchase_Order_Acknowledgement_Date_On_or_BeforeField;
			}
			set
			{
				this.purchase_Order_Acknowledgement_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Purchase_Order_Acknowledgement_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Purchase_Order_Acknowledgement_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.purchase_Order_Acknowledgement_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.purchase_Order_Acknowledgement_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Purchase_Order_Acknowledgement_Date_On_or_BeforeSpecified");
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
