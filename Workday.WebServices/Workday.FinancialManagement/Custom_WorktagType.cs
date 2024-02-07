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
	public class Custom_WorktagType : INotifyPropertyChanged
	{
		private Custom_Worktag_ConfigurationObjectType custom_Worktag_ReferenceField;

		private Custom_Worktag_DataType[] custom_Worktag_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Custom_Worktag_ConfigurationObjectType Custom_Worktag_Reference
		{
			get
			{
				return this.custom_Worktag_ReferenceField;
			}
			set
			{
				this.custom_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_Reference");
			}
		}

		[XmlElement("Custom_Worktag_Data", Order = 1)]
		public Custom_Worktag_DataType[] Custom_Worktag_Data
		{
			get
			{
				return this.custom_Worktag_DataField;
			}
			set
			{
				this.custom_Worktag_DataField = value;
				this.RaisePropertyChanged("Custom_Worktag_Data");
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
