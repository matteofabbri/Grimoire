using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Account_Posting_Rule_Condition_Value_Group_ReferenceType : INotifyPropertyChanged
	{
		private bool is_Intercompany_AffiliateField;

		private bool is_Intercompany_AffiliateFieldSpecified;

		private bool is_Interworktag_AffiliateField;

		private bool is_Interworktag_AffiliateFieldSpecified;

		private Account_Posting_Rule_Condition_ValueObjectType[] account_Posting_Rule_Condition_Value_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Is_Intercompany_Affiliate
		{
			get
			{
				return this.is_Intercompany_AffiliateField;
			}
			set
			{
				this.is_Intercompany_AffiliateField = value;
				this.RaisePropertyChanged("Is_Intercompany_Affiliate");
			}
		}

		[XmlIgnore]
		public bool Is_Intercompany_AffiliateSpecified
		{
			get
			{
				return this.is_Intercompany_AffiliateFieldSpecified;
			}
			set
			{
				this.is_Intercompany_AffiliateFieldSpecified = value;
				this.RaisePropertyChanged("Is_Intercompany_AffiliateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Is_Interworktag_Affiliate
		{
			get
			{
				return this.is_Interworktag_AffiliateField;
			}
			set
			{
				this.is_Interworktag_AffiliateField = value;
				this.RaisePropertyChanged("Is_Interworktag_Affiliate");
			}
		}

		[XmlIgnore]
		public bool Is_Interworktag_AffiliateSpecified
		{
			get
			{
				return this.is_Interworktag_AffiliateFieldSpecified;
			}
			set
			{
				this.is_Interworktag_AffiliateFieldSpecified = value;
				this.RaisePropertyChanged("Is_Interworktag_AffiliateSpecified");
			}
		}

		[XmlElement("Account_Posting_Rule_Condition_Value_Reference", Order = 2)]
		public Account_Posting_Rule_Condition_ValueObjectType[] Account_Posting_Rule_Condition_Value_Reference
		{
			get
			{
				return this.account_Posting_Rule_Condition_Value_ReferenceField;
			}
			set
			{
				this.account_Posting_Rule_Condition_Value_ReferenceField = value;
				this.RaisePropertyChanged("Account_Posting_Rule_Condition_Value_Reference");
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
