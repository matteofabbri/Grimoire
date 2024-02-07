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
	public class Orientation_OfferingType : INotifyPropertyChanged
	{
		private Orientation_OfferingObjectType orientation_Offering_ReferenceField;

		private Orientation_Offering_DataType[] orientation_Offering_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Orientation_OfferingObjectType Orientation_Offering_Reference
		{
			get
			{
				return this.orientation_Offering_ReferenceField;
			}
			set
			{
				this.orientation_Offering_ReferenceField = value;
				this.RaisePropertyChanged("Orientation_Offering_Reference");
			}
		}

		[XmlElement("Orientation_Offering_Data", Order = 1)]
		public Orientation_Offering_DataType[] Orientation_Offering_Data
		{
			get
			{
				return this.orientation_Offering_DataField;
			}
			set
			{
				this.orientation_Offering_DataField = value;
				this.RaisePropertyChanged("Orientation_Offering_Data");
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
