using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Work_Experience_DataType : INotifyPropertyChanged
	{
		private Work_Experience_SkillObjectType experience_ReferenceField;

		private bool remove_ExperienceField;

		private bool remove_ExperienceFieldSpecified;

		private Work_Experience_RatingObjectType experience_Rating_ReferenceField;

		private string experience_CommentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Work_Experience_SkillObjectType Experience_Reference
		{
			get
			{
				return this.experience_ReferenceField;
			}
			set
			{
				this.experience_ReferenceField = value;
				this.RaisePropertyChanged("Experience_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Remove_Experience
		{
			get
			{
				return this.remove_ExperienceField;
			}
			set
			{
				this.remove_ExperienceField = value;
				this.RaisePropertyChanged("Remove_Experience");
			}
		}

		[XmlIgnore]
		public bool Remove_ExperienceSpecified
		{
			get
			{
				return this.remove_ExperienceFieldSpecified;
			}
			set
			{
				this.remove_ExperienceFieldSpecified = value;
				this.RaisePropertyChanged("Remove_ExperienceSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Work_Experience_RatingObjectType Experience_Rating_Reference
		{
			get
			{
				return this.experience_Rating_ReferenceField;
			}
			set
			{
				this.experience_Rating_ReferenceField = value;
				this.RaisePropertyChanged("Experience_Rating_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Experience_Comment
		{
			get
			{
				return this.experience_CommentField;
			}
			set
			{
				this.experience_CommentField = value;
				this.RaisePropertyChanged("Experience_Comment");
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
