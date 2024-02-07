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
	public class Student_Course_Special_Topic_DataType : INotifyPropertyChanged
	{
		private string special_Topic_NameField;

		private bool special_Topic_Display_On_TranscriptField;

		private bool special_Topic_Display_On_TranscriptFieldSpecified;

		private bool special_Topic_RepeatableField;

		private bool special_Topic_RepeatableFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Special_Topic_Name
		{
			get
			{
				return this.special_Topic_NameField;
			}
			set
			{
				this.special_Topic_NameField = value;
				this.RaisePropertyChanged("Special_Topic_Name");
			}
		}

		[XmlElement(Order = 1)]
		public bool Special_Topic_Display_On_Transcript
		{
			get
			{
				return this.special_Topic_Display_On_TranscriptField;
			}
			set
			{
				this.special_Topic_Display_On_TranscriptField = value;
				this.RaisePropertyChanged("Special_Topic_Display_On_Transcript");
			}
		}

		[XmlIgnore]
		public bool Special_Topic_Display_On_TranscriptSpecified
		{
			get
			{
				return this.special_Topic_Display_On_TranscriptFieldSpecified;
			}
			set
			{
				this.special_Topic_Display_On_TranscriptFieldSpecified = value;
				this.RaisePropertyChanged("Special_Topic_Display_On_TranscriptSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Special_Topic_Repeatable
		{
			get
			{
				return this.special_Topic_RepeatableField;
			}
			set
			{
				this.special_Topic_RepeatableField = value;
				this.RaisePropertyChanged("Special_Topic_Repeatable");
			}
		}

		[XmlIgnore]
		public bool Special_Topic_RepeatableSpecified
		{
			get
			{
				return this.special_Topic_RepeatableFieldSpecified;
			}
			set
			{
				this.special_Topic_RepeatableFieldSpecified = value;
				this.RaisePropertyChanged("Special_Topic_RepeatableSpecified");
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
