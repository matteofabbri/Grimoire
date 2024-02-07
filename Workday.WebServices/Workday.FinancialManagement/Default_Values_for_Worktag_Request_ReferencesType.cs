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
	public class Default_Values_for_Worktag_Request_ReferencesType : INotifyPropertyChanged
	{
		private Worktag_with_Related_WorktagsObjectType[] related_Worktag_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Related_Worktag_Reference", Order = 0)]
		public Worktag_with_Related_WorktagsObjectType[] Related_Worktag_Reference
		{
			get
			{
				return this.related_Worktag_ReferenceField;
			}
			set
			{
				this.related_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Related_Worktag_Reference");
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
