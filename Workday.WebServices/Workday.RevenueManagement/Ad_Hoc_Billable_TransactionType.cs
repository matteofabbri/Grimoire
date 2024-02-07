using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Ad_Hoc_Billable_TransactionType : INotifyPropertyChanged
	{
		private Ad_Hoc_Billable_TransactionObjectType ad_Hoc_Billable_Transaction_ReferenceField;

		private Ad_Hoc_Billable_Transaction_DataType[] ad_Hoc_Billable_Transaction_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Ad_Hoc_Billable_TransactionObjectType Ad_Hoc_Billable_Transaction_Reference
		{
			get
			{
				return this.ad_Hoc_Billable_Transaction_ReferenceField;
			}
			set
			{
				this.ad_Hoc_Billable_Transaction_ReferenceField = value;
				this.RaisePropertyChanged("Ad_Hoc_Billable_Transaction_Reference");
			}
		}

		[XmlElement("Ad_Hoc_Billable_Transaction_Data", Order = 1)]
		public Ad_Hoc_Billable_Transaction_DataType[] Ad_Hoc_Billable_Transaction_Data
		{
			get
			{
				return this.ad_Hoc_Billable_Transaction_DataField;
			}
			set
			{
				this.ad_Hoc_Billable_Transaction_DataField = value;
				this.RaisePropertyChanged("Ad_Hoc_Billable_Transaction_Data");
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
