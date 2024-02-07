using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Get_Notice_Periods_Request_ReferencesType : INotifyPropertyChanged
	{
		private Notice_Period_TargetObjectType notice_Period_Target_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Notice_Period_TargetObjectType Notice_Period_Target_Reference
		{
			get
			{
				return this.notice_Period_Target_ReferenceField;
			}
			set
			{
				this.notice_Period_Target_ReferenceField = value;
				this.RaisePropertyChanged("Notice_Period_Target_Reference");
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
