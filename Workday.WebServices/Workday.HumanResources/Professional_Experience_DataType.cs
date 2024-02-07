using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Professional_Experience_DataType : INotifyPropertyChanged
	{
		private string professional_ExperienceField;

		private Professional_Experience_Rating_ReferenceType professional_Experience_Rating_ReferenceField;

		private string professional_Experience_CommentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Professional_Experience
		{
			get
			{
				return this.professional_ExperienceField;
			}
			set
			{
				this.professional_ExperienceField = value;
				this.RaisePropertyChanged("Professional_Experience");
			}
		}

		[XmlElement(Order = 1)]
		public Professional_Experience_Rating_ReferenceType Professional_Experience_Rating_Reference
		{
			get
			{
				return this.professional_Experience_Rating_ReferenceField;
			}
			set
			{
				this.professional_Experience_Rating_ReferenceField = value;
				this.RaisePropertyChanged("Professional_Experience_Rating_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Professional_Experience_Comment
		{
			get
			{
				return this.professional_Experience_CommentField;
			}
			set
			{
				this.professional_Experience_CommentField = value;
				this.RaisePropertyChanged("Professional_Experience_Comment");
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
