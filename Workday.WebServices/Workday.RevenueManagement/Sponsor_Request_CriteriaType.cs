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
	public class Sponsor_Request_CriteriaType : INotifyPropertyChanged
	{
		private object itemField;

		private string sponsor_Reference_IDField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Event_Reference", typeof(Transaction_LogObjectType), Order = 0), XmlElement("Reporting_Transaction_Reference", typeof(Reporting_TransactionObjectType), Order = 0)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 1)]
		public string Sponsor_Reference_ID
		{
			get
			{
				return this.sponsor_Reference_IDField;
			}
			set
			{
				this.sponsor_Reference_IDField = value;
				this.RaisePropertyChanged("Sponsor_Reference_ID");
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
