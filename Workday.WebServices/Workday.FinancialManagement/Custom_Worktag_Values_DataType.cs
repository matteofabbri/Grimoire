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
	public class Custom_Worktag_Values_DataType : INotifyPropertyChanged
	{
		private string custom_Worktag_IDField;

		private string worktag_ValueField;

		private bool inactive_Custom_WorktagField;

		private bool inactive_Custom_WorktagFieldSpecified;

		private Related_Worktags_by_Worktag_Type_DataType[] related_Worktags_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Custom_Worktag_ID
		{
			get
			{
				return this.custom_Worktag_IDField;
			}
			set
			{
				this.custom_Worktag_IDField = value;
				this.RaisePropertyChanged("Custom_Worktag_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Worktag_Value
		{
			get
			{
				return this.worktag_ValueField;
			}
			set
			{
				this.worktag_ValueField = value;
				this.RaisePropertyChanged("Worktag_Value");
			}
		}

		[XmlElement(Order = 2)]
		public bool Inactive_Custom_Worktag
		{
			get
			{
				return this.inactive_Custom_WorktagField;
			}
			set
			{
				this.inactive_Custom_WorktagField = value;
				this.RaisePropertyChanged("Inactive_Custom_Worktag");
			}
		}

		[XmlIgnore]
		public bool Inactive_Custom_WorktagSpecified
		{
			get
			{
				return this.inactive_Custom_WorktagFieldSpecified;
			}
			set
			{
				this.inactive_Custom_WorktagFieldSpecified = value;
				this.RaisePropertyChanged("Inactive_Custom_WorktagSpecified");
			}
		}

		[XmlArray(Order = 3), XmlArrayItem("Related_Worktags_by_Type_Data", IsNullable = false)]
		public Related_Worktags_by_Worktag_Type_DataType[] Related_Worktags_Data
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
