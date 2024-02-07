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
	public class Default_Values_for_Worktag_DataType : INotifyPropertyChanged
	{
		private Worktag_with_Related_WorktagsObjectType related_Worktag_ReferenceField;

		private Accounting_WorktagObjectType[] default_WorktagsField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Worktag_with_Related_WorktagsObjectType Related_Worktag_Reference
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

		[XmlArray(Order = 1), XmlArrayItem("Worktags_Reference", IsNullable = false)]
		public Accounting_WorktagObjectType[] Default_Worktags
		{
			get
			{
				return this.default_WorktagsField;
			}
			set
			{
				this.default_WorktagsField = value;
				this.RaisePropertyChanged("Default_Worktags");
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
