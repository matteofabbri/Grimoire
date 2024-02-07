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
	public class Custom_Worktag_Request_ReferencesType : INotifyPropertyChanged
	{
		private Custom_Worktag_ConfigurationObjectType[] custom_Worktag_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Custom_Worktag_Reference", Order = 0)]
		public Custom_Worktag_ConfigurationObjectType[] Custom_Worktag_Reference
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
