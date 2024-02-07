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
	public class Integration_Worktag_Mapping_Source_System_Request_ReferencesType : INotifyPropertyChanged
	{
		private Integration_Worktag_Mapping_Source_SystemObjectType[] source_System_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Source_System_Reference", Order = 0)]
		public Integration_Worktag_Mapping_Source_SystemObjectType[] Source_System_Reference
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
