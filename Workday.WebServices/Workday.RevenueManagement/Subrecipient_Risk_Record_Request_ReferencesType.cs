using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Subrecipient_Risk_Record_Request_ReferencesType : INotifyPropertyChanged
	{
		private Risk_EvaluationObjectType[] subrecipient_Risk_Record_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Subrecipient_Risk_Record_Reference", Order = 0)]
		public Risk_EvaluationObjectType[] Subrecipient_Risk_Record_Reference
		{
			get
			{
				return this.subrecipient_Risk_Record_ReferenceField;
			}
			set
			{
				this.subrecipient_Risk_Record_ReferenceField = value;
				this.RaisePropertyChanged("Subrecipient_Risk_Record_Reference");
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
