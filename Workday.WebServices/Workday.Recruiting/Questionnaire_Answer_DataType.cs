using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Questionnaire_Answer_DataType : INotifyPropertyChanged
	{
		private Question_SetupObjectType question_Setup_ReferenceField;

		private object[] itemsField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Question_SetupObjectType Question_Setup_Reference
		{
			get
			{
				return this.question_Setup_ReferenceField;
			}
			set
			{
				this.question_Setup_ReferenceField = value;
				this.RaisePropertyChanged("Question_Setup_Reference");
			}
		}

		[XmlElement("Answer_Date", typeof(DateTime), DataType = "date", Order = 1), XmlElement("Answer_Numeric", typeof(decimal), Order = 1), XmlElement("Answer_Text", typeof(string), Order = 1), XmlElement("Multiple_Choice_Answer_Data", typeof(Multiple_Choice_Answer_DataType), Order = 1)]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
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
