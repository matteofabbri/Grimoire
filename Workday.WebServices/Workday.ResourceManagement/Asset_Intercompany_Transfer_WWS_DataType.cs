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
	public class Asset_Intercompany_Transfer_WWS_DataType : INotifyPropertyChanged
	{
		private DateTime transaction_Effective_DateField;

		private bool transaction_Effective_DateFieldSpecified;

		private CompanyObjectType transfer_To_Company_ReferenceField;

		private CompanyObjectType transfer_From_Company_ReferenceField;

		private decimal accumulated_DepreciationField;

		private bool accumulated_DepreciationFieldSpecified;

		private Business_AssetObjectType transfer_To_Asset_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Transaction_Effective_Date
		{
			get
			{
				return this.transaction_Effective_DateField;
			}
			set
			{
				this.transaction_Effective_DateField = value;
				this.RaisePropertyChanged("Transaction_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Transaction_Effective_DateSpecified
		{
			get
			{
				return this.transaction_Effective_DateFieldSpecified;
			}
			set
			{
				this.transaction_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public CompanyObjectType Transfer_To_Company_Reference
		{
			get
			{
				return this.transfer_To_Company_ReferenceField;
			}
			set
			{
				this.transfer_To_Company_ReferenceField = value;
				this.RaisePropertyChanged("Transfer_To_Company_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public CompanyObjectType Transfer_From_Company_Reference
		{
			get
			{
				return this.transfer_From_Company_ReferenceField;
			}
			set
			{
				this.transfer_From_Company_ReferenceField = value;
				this.RaisePropertyChanged("Transfer_From_Company_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Accumulated_Depreciation
		{
			get
			{
				return this.accumulated_DepreciationField;
			}
			set
			{
				this.accumulated_DepreciationField = value;
				this.RaisePropertyChanged("Accumulated_Depreciation");
			}
		}

		[XmlIgnore]
		public bool Accumulated_DepreciationSpecified
		{
			get
			{
				return this.accumulated_DepreciationFieldSpecified;
			}
			set
			{
				this.accumulated_DepreciationFieldSpecified = value;
				this.RaisePropertyChanged("Accumulated_DepreciationSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Business_AssetObjectType Transfer_To_Asset_Reference
		{
			get
			{
				return this.transfer_To_Asset_ReferenceField;
			}
			set
			{
				this.transfer_To_Asset_ReferenceField = value;
				this.RaisePropertyChanged("Transfer_To_Asset_Reference");
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
