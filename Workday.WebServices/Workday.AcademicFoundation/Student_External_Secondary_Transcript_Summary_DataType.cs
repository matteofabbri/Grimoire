using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_External_Secondary_Transcript_Summary_DataType : INotifyPropertyChanged
	{
		private decimal class_RankField;

		private bool class_RankFieldSpecified;

		private decimal class_SizeField;

		private bool class_SizeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Class_Rank
		{
			get
			{
				return this.class_RankField;
			}
			set
			{
				this.class_RankField = value;
				this.RaisePropertyChanged("Class_Rank");
			}
		}

		[XmlIgnore]
		public bool Class_RankSpecified
		{
			get
			{
				return this.class_RankFieldSpecified;
			}
			set
			{
				this.class_RankFieldSpecified = value;
				this.RaisePropertyChanged("Class_RankSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Class_Size
		{
			get
			{
				return this.class_SizeField;
			}
			set
			{
				this.class_SizeField = value;
				this.RaisePropertyChanged("Class_Size");
			}
		}

		[XmlIgnore]
		public bool Class_SizeSpecified
		{
			get
			{
				return this.class_SizeFieldSpecified;
			}
			set
			{
				this.class_SizeFieldSpecified = value;
				this.RaisePropertyChanged("Class_SizeSpecified");
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
