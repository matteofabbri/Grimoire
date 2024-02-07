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
	public class Deferred_Cost_TransactionType : INotifyPropertyChanged
	{
		private Deferred_Cost_TransactionObjectType deferred_Cost_Transaction_ReferenceField;

		private Deferred_Cost_Transaction_DataType[] deferred_Cost_Transaction_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Deferred_Cost_TransactionObjectType Deferred_Cost_Transaction_Reference
		{
			get
			{
				return this.deferred_Cost_Transaction_ReferenceField;
			}
			set
			{
				this.deferred_Cost_Transaction_ReferenceField = value;
				this.RaisePropertyChanged("Deferred_Cost_Transaction_Reference");
			}
		}

		[XmlElement("Deferred_Cost_Transaction_Data", Order = 1)]
		public Deferred_Cost_Transaction_DataType[] Deferred_Cost_Transaction_Data
		{
			get
			{
				return this.deferred_Cost_Transaction_DataField;
			}
			set
			{
				this.deferred_Cost_Transaction_DataField = value;
				this.RaisePropertyChanged("Deferred_Cost_Transaction_Data");
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
