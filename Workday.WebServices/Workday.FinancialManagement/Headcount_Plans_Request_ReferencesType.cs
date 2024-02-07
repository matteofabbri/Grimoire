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
	public class Headcount_Plans_Request_ReferencesType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType[] headcount_Plan_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Headcount_Plan_Reference", Order = 0)]
		public Unique_IdentifierObjectType[] Headcount_Plan_Reference
		{
			get
			{
				return this.headcount_Plan_ReferenceField;
			}
			set
			{
				this.headcount_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Headcount_Plan_Reference");
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
