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
	public class Integration_Worktag_Mapping_Source_SystemType : INotifyPropertyChanged
	{
		private Integration_Worktag_Mapping_Source_SystemObjectType source_System_ReferenceField;

		private Integration_Worktag_Mapping_Source_System_DataType source_System_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Integration_Worktag_Mapping_Source_SystemObjectType Source_System_Reference
		{
			get
			{
				return this.source_System_ReferenceField;
			}
			set
			{
				this.source_System_ReferenceField = value;
				this.RaisePropertyChanged("Source_System_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Integration_Worktag_Mapping_Source_System_DataType Source_System_Data
		{
			get
			{
				return this.source_System_DataField;
			}
			set
			{
				this.source_System_DataField = value;
				this.RaisePropertyChanged("Source_System_Data");
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
