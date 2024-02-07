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
	public class Subrecipient_Risk_RecordType : INotifyPropertyChanged
	{
		private Risk_EvaluationObjectType subrecipient_Risk_Record_ReferenceField;

		private Subrecipient_Risk_Record_DataType subrecipient_Risk_Record_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Risk_EvaluationObjectType Subrecipient_Risk_Record_Reference
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

		[XmlElement(Order = 1)]
		public Subrecipient_Risk_Record_DataType Subrecipient_Risk_Record_Data
		{
			get
			{
				return this.subrecipient_Risk_Record_DataField;
			}
			set
			{
				this.subrecipient_Risk_Record_DataField = value;
				this.RaisePropertyChanged("Subrecipient_Risk_Record_Data");
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
