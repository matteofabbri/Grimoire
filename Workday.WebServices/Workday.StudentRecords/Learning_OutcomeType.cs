using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Learning_OutcomeType : INotifyPropertyChanged
	{
		private Learning_OutcomeObjectType learning_Outcome_ReferenceField;

		private Learning_Outcome_DataType[] learning_Outcome_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Learning_OutcomeObjectType Learning_Outcome_Reference
		{
			get
			{
				return this.learning_Outcome_ReferenceField;
			}
			set
			{
				this.learning_Outcome_ReferenceField = value;
				this.RaisePropertyChanged("Learning_Outcome_Reference");
			}
		}

		[XmlElement("Learning_Outcome_Data", Order = 1)]
		public Learning_Outcome_DataType[] Learning_Outcome_Data
		{
			get
			{
				return this.learning_Outcome_DataField;
			}
			set
			{
				this.learning_Outcome_DataField = value;
				this.RaisePropertyChanged("Learning_Outcome_Data");
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
