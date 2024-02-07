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
	public class Areas_Changed_WWS_DataType : INotifyPropertyChanged
	{
		private bool supplier_and_Tax_DetailsField;

		private bool supplier_and_Tax_DetailsFieldSpecified;

		private bool payment_DetailsField;

		private bool payment_DetailsFieldSpecified;

		private bool supplier_HierarchyField;

		private bool supplier_HierarchyFieldSpecified;

		private bool contact_InformationField;

		private bool contact_InformationFieldSpecified;

		private bool settlement_Bank_AccountField;

		private bool settlement_Bank_AccountFieldSpecified;

		private bool alternate_NamesField;

		private bool alternate_NamesFieldSpecified;

		private bool procurement_OptionsField;

		private bool procurement_OptionsFieldSpecified;

		private bool classificationsField;

		private bool classificationsFieldSpecified;

		private bool contingent__Worker__OptionsField;

		private bool contingent__Worker__OptionsFieldSpecified;

		private bool attachmentsField;

		private bool attachmentsFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Supplier_and_Tax_Details
		{
			get
			{
				return this.supplier_and_Tax_DetailsField;
			}
			set
			{
				this.supplier_and_Tax_DetailsField = value;
				this.RaisePropertyChanged("Supplier_and_Tax_Details");
			}
		}

		[XmlIgnore]
		public bool Supplier_and_Tax_DetailsSpecified
		{
			get
			{
				return this.supplier_and_Tax_DetailsFieldSpecified;
			}
			set
			{
				this.supplier_and_Tax_DetailsFieldSpecified = value;
				this.RaisePropertyChanged("Supplier_and_Tax_DetailsSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Payment_Details
		{
			get
			{
				return this.payment_DetailsField;
			}
			set
			{
				this.payment_DetailsField = value;
				this.RaisePropertyChanged("Payment_Details");
			}
		}

		[XmlIgnore]
		public bool Payment_DetailsSpecified
		{
			get
			{
				return this.payment_DetailsFieldSpecified;
			}
			set
			{
				this.payment_DetailsFieldSpecified = value;
				this.RaisePropertyChanged("Payment_DetailsSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Supplier_Hierarchy
		{
			get
			{
				return this.supplier_HierarchyField;
			}
			set
			{
				this.supplier_HierarchyField = value;
				this.RaisePropertyChanged("Supplier_Hierarchy");
			}
		}

		[XmlIgnore]
		public bool Supplier_HierarchySpecified
		{
			get
			{
				return this.supplier_HierarchyFieldSpecified;
			}
			set
			{
				this.supplier_HierarchyFieldSpecified = value;
				this.RaisePropertyChanged("Supplier_HierarchySpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Contact_Information
		{
			get
			{
				return this.contact_InformationField;
			}
			set
			{
				this.contact_InformationField = value;
				this.RaisePropertyChanged("Contact_Information");
			}
		}

		[XmlIgnore]
		public bool Contact_InformationSpecified
		{
			get
			{
				return this.contact_InformationFieldSpecified;
			}
			set
			{
				this.contact_InformationFieldSpecified = value;
				this.RaisePropertyChanged("Contact_InformationSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Settlement_Bank_Account
		{
			get
			{
				return this.settlement_Bank_AccountField;
			}
			set
			{
				this.settlement_Bank_AccountField = value;
				this.RaisePropertyChanged("Settlement_Bank_Account");
			}
		}

		[XmlIgnore]
		public bool Settlement_Bank_AccountSpecified
		{
			get
			{
				return this.settlement_Bank_AccountFieldSpecified;
			}
			set
			{
				this.settlement_Bank_AccountFieldSpecified = value;
				this.RaisePropertyChanged("Settlement_Bank_AccountSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Alternate_Names
		{
			get
			{
				return this.alternate_NamesField;
			}
			set
			{
				this.alternate_NamesField = value;
				this.RaisePropertyChanged("Alternate_Names");
			}
		}

		[XmlIgnore]
		public bool Alternate_NamesSpecified
		{
			get
			{
				return this.alternate_NamesFieldSpecified;
			}
			set
			{
				this.alternate_NamesFieldSpecified = value;
				this.RaisePropertyChanged("Alternate_NamesSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Procurement_Options
		{
			get
			{
				return this.procurement_OptionsField;
			}
			set
			{
				this.procurement_OptionsField = value;
				this.RaisePropertyChanged("Procurement_Options");
			}
		}

		[XmlIgnore]
		public bool Procurement_OptionsSpecified
		{
			get
			{
				return this.procurement_OptionsFieldSpecified;
			}
			set
			{
				this.procurement_OptionsFieldSpecified = value;
				this.RaisePropertyChanged("Procurement_OptionsSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Classifications
		{
			get
			{
				return this.classificationsField;
			}
			set
			{
				this.classificationsField = value;
				this.RaisePropertyChanged("Classifications");
			}
		}

		[XmlIgnore]
		public bool ClassificationsSpecified
		{
			get
			{
				return this.classificationsFieldSpecified;
			}
			set
			{
				this.classificationsFieldSpecified = value;
				this.RaisePropertyChanged("ClassificationsSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Contingent__Worker__Options
		{
			get
			{
				return this.contingent__Worker__OptionsField;
			}
			set
			{
				this.contingent__Worker__OptionsField = value;
				this.RaisePropertyChanged("Contingent__Worker__Options");
			}
		}

		[XmlIgnore]
		public bool Contingent__Worker__OptionsSpecified
		{
			get
			{
				return this.contingent__Worker__OptionsFieldSpecified;
			}
			set
			{
				this.contingent__Worker__OptionsFieldSpecified = value;
				this.RaisePropertyChanged("Contingent__Worker__OptionsSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Attachments
		{
			get
			{
				return this.attachmentsField;
			}
			set
			{
				this.attachmentsField = value;
				this.RaisePropertyChanged("Attachments");
			}
		}

		[XmlIgnore]
		public bool AttachmentsSpecified
		{
			get
			{
				return this.attachmentsFieldSpecified;
			}
			set
			{
				this.attachmentsFieldSpecified = value;
				this.RaisePropertyChanged("AttachmentsSpecified");
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
