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
	public class Journal_SourceType : INotifyPropertyChanged
	{
		private Journal_SourceObjectType journal_Source_ReferenceField;

		private Journal_Source_DataType[] journal_Source_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Journal_SourceObjectType Journal_Source_Reference
		{
			get
			{
				return this.journal_Source_ReferenceField;
			}
			set
			{
				this.journal_Source_ReferenceField = value;
				this.RaisePropertyChanged("Journal_Source_Reference");
			}
		}

		[XmlElement("Journal_Source_Data", Order = 1)]
		public Journal_Source_DataType[] Journal_Source_Data
		{
			get
			{
				return this.journal_Source_DataField;
			}
			set
			{
				this.journal_Source_DataField = value;
				this.RaisePropertyChanged("Journal_Source_Data");
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
