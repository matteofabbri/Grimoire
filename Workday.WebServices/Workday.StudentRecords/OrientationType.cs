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
	public class OrientationType : INotifyPropertyChanged
	{
		private OrientationObjectType orientation_ReferenceField;

		private Orientation_DataType[] orientation_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public OrientationObjectType Orientation_Reference
		{
			get
			{
				return this.orientation_ReferenceField;
			}
			set
			{
				this.orientation_ReferenceField = value;
				this.RaisePropertyChanged("Orientation_Reference");
			}
		}

		[XmlElement("Orientation_Data", Order = 1)]
		public Orientation_DataType[] Orientation_Data
		{
			get
			{
				return this.orientation_DataField;
			}
			set
			{
				this.orientation_DataField = value;
				this.RaisePropertyChanged("Orientation_Data");
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
