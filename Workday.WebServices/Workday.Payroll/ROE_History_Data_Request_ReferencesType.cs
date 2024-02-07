using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class ROE_History_Data_Request_ReferencesType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType[] rOE_History_Data_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("ROE_History_Data_Reference", Order = 0)]
		public Unique_IdentifierObjectType[] ROE_History_Data_Reference
		{
			get
			{
				return this.rOE_History_Data_ReferenceField;
			}
			set
			{
				this.rOE_History_Data_ReferenceField = value;
				this.RaisePropertyChanged("ROE_History_Data_Reference");
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
