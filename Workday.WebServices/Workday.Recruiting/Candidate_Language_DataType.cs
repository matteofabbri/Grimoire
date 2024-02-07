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
	public class Candidate_Language_DataType : INotifyPropertyChanged
	{
		private bool nativeField;

		private bool nativeFieldSpecified;

		private Language_AbilityType[] language_AbilityField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Native
		{
			get
			{
				return this.nativeField;
			}
			set
			{
				this.nativeField = value;
				this.RaisePropertyChanged("Native");
			}
		}

		[XmlIgnore]
		public bool NativeSpecified
		{
			get
			{
				return this.nativeFieldSpecified;
			}
			set
			{
				this.nativeFieldSpecified = value;
				this.RaisePropertyChanged("NativeSpecified");
			}
		}

		[XmlElement("Language_Ability", Order = 1)]
		public Language_AbilityType[] Language_Ability
		{
			get
			{
				return this.language_AbilityField;
			}
			set
			{
				this.language_AbilityField = value;
				this.RaisePropertyChanged("Language_Ability");
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
