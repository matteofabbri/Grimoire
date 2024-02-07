using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Income_Code_for_1042-S_Request_ReferencesType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Income_Code_for_1042S_Request_ReferencesType : INotifyPropertyChanged
	{
		private Income_Code_for_1042SObjectType[] income_Code_for_1042S_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Income_Code_for_1042-S_Reference", Order = 0)]
		public Income_Code_for_1042SObjectType[] Income_Code_for_1042S_Reference
		{
			get
			{
				return this.income_Code_for_1042S_ReferenceField;
			}
			set
			{
				this.income_Code_for_1042S_ReferenceField = value;
				this.RaisePropertyChanged("Income_Code_for_1042S_Reference");
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
