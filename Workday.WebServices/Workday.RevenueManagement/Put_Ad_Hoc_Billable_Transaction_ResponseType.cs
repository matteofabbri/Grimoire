using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Ad_Hoc_Billable_Transaction_ResponseType : INotifyPropertyChanged
	{
		private Ad_Hoc_Billable_TransactionObjectType ad_Hoc_Billable_Transaction_ReferenceField;

		private string versionField;

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

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
