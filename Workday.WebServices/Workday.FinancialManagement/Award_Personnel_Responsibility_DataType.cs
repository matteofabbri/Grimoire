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
	public class Award_Personnel_Responsibility_DataType : INotifyPropertyChanged
	{
		private string award_Personnel_Responsibility_IDField;

		private string award_Personnel_Responsibility_TitleField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Award_Personnel_Responsibility_ID
		{
			get
			{
				return this.award_Personnel_Responsibility_IDField;
			}
			set
			{
				this.award_Personnel_Responsibility_IDField = value;
				this.RaisePropertyChanged("Award_Personnel_Responsibility_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Award_Personnel_Responsibility_Title
		{
			get
			{
				return this.award_Personnel_Responsibility_TitleField;
			}
			set
			{
				this.award_Personnel_Responsibility_TitleField = value;
				this.RaisePropertyChanged("Award_Personnel_Responsibility_Title");
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
