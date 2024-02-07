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
	public class Journal_EntryType : INotifyPropertyChanged
	{
		private Journal_EntryObjectType journal_Entry_ReferenceField;

		private Journal_Entry_DataType[] journal_Entry_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Journal_EntryObjectType Journal_Entry_Reference
		{
			get
			{
				return this.journal_Entry_ReferenceField;
			}
			set
			{
				this.journal_Entry_ReferenceField = value;
				this.RaisePropertyChanged("Journal_Entry_Reference");
			}
		}

		[XmlElement("Journal_Entry_Data", Order = 1)]
		public Journal_Entry_DataType[] Journal_Entry_Data
		{
			get
			{
				return this.journal_Entry_DataField;
			}
			set
			{
				this.journal_Entry_DataField = value;
				this.RaisePropertyChanged("Journal_Entry_Data");
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
