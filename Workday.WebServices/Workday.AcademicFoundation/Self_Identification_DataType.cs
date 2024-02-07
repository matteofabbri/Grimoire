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
	public class Self_Identification_DataType : INotifyPropertyChanged
	{
		private Sexual_OrientationObjectType sexual_Orientation_ReferenceField;

		private Gender_IdentityObjectType gender_Identity_ReferenceField;

		private PronounObjectType pronoun_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Sexual_OrientationObjectType Sexual_Orientation_Reference
		{
			get
			{
				return this.sexual_Orientation_ReferenceField;
			}
			set
			{
				this.sexual_Orientation_ReferenceField = value;
				this.RaisePropertyChanged("Sexual_Orientation_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Gender_IdentityObjectType Gender_Identity_Reference
		{
			get
			{
				return this.gender_Identity_ReferenceField;
			}
			set
			{
				this.gender_Identity_ReferenceField = value;
				this.RaisePropertyChanged("Gender_Identity_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public PronounObjectType Pronoun_Reference
		{
			get
			{
				return this.pronoun_ReferenceField;
			}
			set
			{
				this.pronoun_ReferenceField = value;
				this.RaisePropertyChanged("Pronoun_Reference");
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
