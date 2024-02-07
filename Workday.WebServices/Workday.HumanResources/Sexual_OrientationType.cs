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
	public class Sexual_OrientationType : INotifyPropertyChanged
	{
		private Sexual_OrientationObjectType sexual_Orientation_ReferenceField;

		private Sexual_Orientation_DataType[] sexual_Orientation_DataField;

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

		[XmlElement("Sexual_Orientation_Data", Order = 1)]
		public Sexual_Orientation_DataType[] Sexual_Orientation_Data
		{
			get
			{
				return this.sexual_Orientation_DataField;
			}
			set
			{
				this.sexual_Orientation_DataField = value;
				this.RaisePropertyChanged("Sexual_Orientation_Data");
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
