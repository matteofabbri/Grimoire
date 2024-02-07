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
	public class Asset_Share_Response_DataType : INotifyPropertyChanged
	{
		private string idField;

		private decimal share_PercentField;

		private bool share_PercentFieldSpecified;

		private decimal asset_Share_AmountField;

		private bool asset_Share_AmountFieldSpecified;

		private Asset_ClassObjectType asset_Class_ReferenceField;

		private Asset_TypeObjectType asset_Type_ReferenceField;

		private Accounting_WorktagObjectType[] asset_Worktags_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Share_Percent
		{
			get
			{
				return this.share_PercentField;
			}
			set
			{
				this.share_PercentField = value;
				this.RaisePropertyChanged("Share_Percent");
			}
		}

		[XmlIgnore]
		public bool Share_PercentSpecified
		{
			get
			{
				return this.share_PercentFieldSpecified;
			}
			set
			{
				this.share_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Share_PercentSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Asset_Share_Amount
		{
			get
			{
				return this.asset_Share_AmountField;
			}
			set
			{
				this.asset_Share_AmountField = value;
				this.RaisePropertyChanged("Asset_Share_Amount");
			}
		}

		[XmlIgnore]
		public bool Asset_Share_AmountSpecified
		{
			get
			{
				return this.asset_Share_AmountFieldSpecified;
			}
			set
			{
				this.asset_Share_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Asset_Share_AmountSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Asset_ClassObjectType Asset_Class_Reference
		{
			get
			{
				return this.asset_Class_ReferenceField;
			}
			set
			{
				this.asset_Class_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Class_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Asset_TypeObjectType Asset_Type_Reference
		{
			get
			{
				return this.asset_Type_ReferenceField;
			}
			set
			{
				this.asset_Type_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Type_Reference");
			}
		}

		[XmlElement("Asset_Worktags_Reference", Order = 5)]
		public Accounting_WorktagObjectType[] Asset_Worktags_Reference
		{
			get
			{
				return this.asset_Worktags_ReferenceField;
			}
			set
			{
				this.asset_Worktags_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Worktags_Reference");
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
