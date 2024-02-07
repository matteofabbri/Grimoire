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
	public class Worker_Career_DataType : INotifyPropertyChanged
	{
		private Relocation_Preference_DataType relocation_DataField;

		private Travel_Preference_DataType travel_DataField;

		private Job_ProfileObjectType[] job_Interests_DataField;

		private Career_Preferences_DataType career_Interests_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Relocation_Preference_DataType Relocation_Data
		{
			get
			{
				return this.relocation_DataField;
			}
			set
			{
				this.relocation_DataField = value;
				this.RaisePropertyChanged("Relocation_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Travel_Preference_DataType Travel_Data
		{
			get
			{
				return this.travel_DataField;
			}
			set
			{
				this.travel_DataField = value;
				this.RaisePropertyChanged("Travel_Data");
			}
		}

		[XmlArray(Order = 2), XmlArrayItem("Job_Profile_Reference", IsNullable = false)]
		public Job_ProfileObjectType[] Job_Interests_Data
		{
			get
			{
				return this.job_Interests_DataField;
			}
			set
			{
				this.job_Interests_DataField = value;
				this.RaisePropertyChanged("Job_Interests_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Career_Preferences_DataType Career_Interests_Data
		{
			get
			{
				return this.career_Interests_DataField;
			}
			set
			{
				this.career_Interests_DataField = value;
				this.RaisePropertyChanged("Career_Interests_Data");
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
