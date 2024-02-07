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
	public class Custom_Worktag_DataType : INotifyPropertyChanged
	{
		private string custom_Worktag_Configuration_IDField;

		private Custom_Worktag_Values_DataType[] custom_Worktag_Values_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Custom_Worktag_Configuration_ID
		{
			get
			{
				return this.custom_Worktag_Configuration_IDField;
			}
			set
			{
				this.custom_Worktag_Configuration_IDField = value;
				this.RaisePropertyChanged("Custom_Worktag_Configuration_ID");
			}
		}

		[XmlElement("Custom_Worktag_Values_Data", Order = 1)]
		public Custom_Worktag_Values_DataType[] Custom_Worktag_Values_Data
		{
			get
			{
				return this.custom_Worktag_Values_DataField;
			}
			set
			{
				this.custom_Worktag_Values_DataField = value;
				this.RaisePropertyChanged("Custom_Worktag_Values_Data");
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
