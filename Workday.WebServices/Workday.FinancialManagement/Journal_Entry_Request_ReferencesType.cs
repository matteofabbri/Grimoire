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
	public class Journal_Entry_Request_ReferencesType : INotifyPropertyChanged
	{
		private Journal_EntryObjectType[] journalEntryReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("JournalEntryReference", Order = 0)]
		public Journal_EntryObjectType[] JournalEntryReference
		{
			get
			{
				return this.journalEntryReferenceField;
			}
			set
			{
				this.journalEntryReferenceField = value;
				this.RaisePropertyChanged("JournalEntryReference");
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
