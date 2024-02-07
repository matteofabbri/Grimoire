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
	public class Related_WorktagsType : INotifyPropertyChanged
	{
		private Worktag_with_Related_WorktagsObjectType related_Worktag_ReferenceField;

		private Worktag_Type_Configuration_SetObjectType worktag_Type_Configuration_Set_ReferenceField;

		private Related_Worktag_Widget_Data_with_Reference_IDType[] related_Worktags_DataField;

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

		[XmlElement(Order = 1)]
		public Worktag_Type_Configuration_SetObjectType Worktag_Type_Configuration_Set_Reference
		{
			get
			{
				return this.worktag_Type_Configuration_Set_ReferenceField;
			}
			set
			{
				this.worktag_Type_Configuration_Set_ReferenceField = value;
				this.RaisePropertyChanged("Worktag_Type_Configuration_Set_Reference");
			}
		}

		[XmlElement("Related_Worktags_Data", Order = 2)]
		public Related_Worktag_Widget_Data_with_Reference_IDType[] Related_Worktags_Data
		{
			get
			{
				return this.related_Worktags_DataField;
			}
			set
			{
				this.related_Worktags_DataField = value;
				this.RaisePropertyChanged("Related_Worktags_Data");
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
