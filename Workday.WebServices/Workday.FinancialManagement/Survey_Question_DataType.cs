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
	public class Survey_Question_DataType : INotifyPropertyChanged
	{
		private string survey_Question_OrderField;

		private Effort_Certification_Survey_Question_TypeObjectType survey_Question_Type_ReferenceField;

		private bool survey_Question_RequiredField;

		private bool survey_Question_RequiredFieldSpecified;

		private string survey_Question_TextField;

		private Multiple_Choice_Question_Option_DataType[] multiple_Choice_Question_Option_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Survey_Question_Order
		{
			get
			{
				return this.survey_Question_OrderField;
			}
			set
			{
				this.survey_Question_OrderField = value;
				this.RaisePropertyChanged("Survey_Question_Order");
			}
		}

		[XmlElement(Order = 1)]
		public Effort_Certification_Survey_Question_TypeObjectType Survey_Question_Type_Reference
		{
			get
			{
				return this.survey_Question_Type_ReferenceField;
			}
			set
			{
				this.survey_Question_Type_ReferenceField = value;
				this.RaisePropertyChanged("Survey_Question_Type_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public bool Survey_Question_Required
		{
			get
			{
				return this.survey_Question_RequiredField;
			}
			set
			{
				this.survey_Question_RequiredField = value;
				this.RaisePropertyChanged("Survey_Question_Required");
			}
		}

		[XmlIgnore]
		public bool Survey_Question_RequiredSpecified
		{
			get
			{
				return this.survey_Question_RequiredFieldSpecified;
			}
			set
			{
				this.survey_Question_RequiredFieldSpecified = value;
				this.RaisePropertyChanged("Survey_Question_RequiredSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Survey_Question_Text
		{
			get
			{
				return this.survey_Question_TextField;
			}
			set
			{
				this.survey_Question_TextField = value;
				this.RaisePropertyChanged("Survey_Question_Text");
			}
		}

		[XmlElement("Multiple_Choice_Question_Option_Reference", Order = 4)]
		public Multiple_Choice_Question_Option_DataType[] Multiple_Choice_Question_Option_Reference
		{
			get
			{
				return this.multiple_Choice_Question_Option_ReferenceField;
			}
			set
			{
				this.multiple_Choice_Question_Option_ReferenceField = value;
				this.RaisePropertyChanged("Multiple_Choice_Question_Option_Reference");
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
