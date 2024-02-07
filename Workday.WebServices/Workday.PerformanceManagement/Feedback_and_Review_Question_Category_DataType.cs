using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Feedback_and_Review_Question_Category_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string question_Category_NameField;

		private decimal in_UseField;

		private bool in_UseFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Question_Category_Name
		{
			get
			{
				return this.question_Category_NameField;
			}
			set
			{
				this.question_Category_NameField = value;
				this.RaisePropertyChanged("Question_Category_Name");
			}
		}

		[XmlElement(Order = 2)]
		public decimal In_Use
		{
			get
			{
				return this.in_UseField;
			}
			set
			{
				this.in_UseField = value;
				this.RaisePropertyChanged("In_Use");
			}
		}

		[XmlIgnore]
		public bool In_UseSpecified
		{
			get
			{
				return this.in_UseFieldSpecified;
			}
			set
			{
				this.in_UseFieldSpecified = value;
				this.RaisePropertyChanged("In_UseSpecified");
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
