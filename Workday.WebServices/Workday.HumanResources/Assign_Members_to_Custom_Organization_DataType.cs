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
	public class Assign_Members_to_Custom_Organization_DataType : INotifyPropertyChanged
	{
		private ReorganizationObjectType reorganization_ReferenceField;

		private Position_ElementObjectType[] positions_to_Add_ReferenceField;

		private Position_ElementObjectType[] positions_to_Remove_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public ReorganizationObjectType Reorganization_Reference
		{
			get
			{
				return this.reorganization_ReferenceField;
			}
			set
			{
				this.reorganization_ReferenceField = value;
				this.RaisePropertyChanged("Reorganization_Reference");
			}
		}

		[XmlElement("Positions_to_Add_Reference", Order = 1)]
		public Position_ElementObjectType[] Positions_to_Add_Reference
		{
			get
			{
				return this.positions_to_Add_ReferenceField;
			}
			set
			{
				this.positions_to_Add_ReferenceField = value;
				this.RaisePropertyChanged("Positions_to_Add_Reference");
			}
		}

		[XmlElement("Positions_to_Remove_Reference", Order = 2)]
		public Position_ElementObjectType[] Positions_to_Remove_Reference
		{
			get
			{
				return this.positions_to_Remove_ReferenceField;
			}
			set
			{
				this.positions_to_Remove_ReferenceField = value;
				this.RaisePropertyChanged("Positions_to_Remove_Reference");
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
