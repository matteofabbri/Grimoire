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
	public class Asset_Depreciation_Schedule_Additional_InformationType : INotifyPropertyChanged
	{
		private Document_StatusObjectType asset_Book_Configuration_Status_ReferenceField;

		private decimal historical_Cost_BalanceField;

		private bool historical_Cost_BalanceFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Document_StatusObjectType Asset_Book_Configuration_Status_Reference
		{
			get
			{
				return this.asset_Book_Configuration_Status_ReferenceField;
			}
			set
			{
				this.asset_Book_Configuration_Status_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Book_Configuration_Status_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Historical_Cost_Balance
		{
			get
			{
				return this.historical_Cost_BalanceField;
			}
			set
			{
				this.historical_Cost_BalanceField = value;
				this.RaisePropertyChanged("Historical_Cost_Balance");
			}
		}

		[XmlIgnore]
		public bool Historical_Cost_BalanceSpecified
		{
			get
			{
				return this.historical_Cost_BalanceFieldSpecified;
			}
			set
			{
				this.historical_Cost_BalanceFieldSpecified = value;
				this.RaisePropertyChanged("Historical_Cost_BalanceSpecified");
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
