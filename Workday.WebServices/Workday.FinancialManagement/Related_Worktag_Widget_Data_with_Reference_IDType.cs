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
	public class Related_Worktag_Widget_Data_with_Reference_IDType : INotifyPropertyChanged
	{
		private Worktag_with_Related_WorktagsObjectType related_Worktag_ReferenceField;

		private Related_Worktags_by_Worktag_Type_DataType[] related_Worktags_by_Type_DataField;

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

		[XmlElement("Related_Worktags_by_Type_Data", Order = 1)]
		public Related_Worktags_by_Worktag_Type_DataType[] Related_Worktags_by_Type_Data
		{
			get
			{
				return this.related_Worktags_by_Type_DataField;
			}
			set
			{
				this.related_Worktags_by_Type_DataField = value;
				this.RaisePropertyChanged("Related_Worktags_by_Type_Data");
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
